using AutoMapper;
using BLL.Models;
using DAL.Entities;
using DAL.Repository;
using System.Linq.Expressions;

namespace BLL.Interfaces;

public class SongService : IService<Song>
{
    private readonly SongRepository _songRepository;
    private readonly Mapper _mapper;

    public SongService()
    {
        _songRepository = new SongRepository();
        var config = new MapperConfiguration(cfg => {
            cfg.CreateMap<Song, SongData>();
            cfg.CreateMap<Author, AuthorData>(); // error
            });
        _mapper = new Mapper(config);
    }

    public void Add(Song item)
    {
        _songRepository.Add(_mapper.Map<SongData>(item));
    }

    public List<Song> GetAll()
    {
        return _songRepository.GetAll()
            .Select(s => new Song()
            {
                Id = s.Id,
                Title = s.Title,
                Duration = s.Duration,
                Genre = s.Genre,
                Author = new Author()
                {
                    Name = s.Author.Name,
                }
            })
            .ToList();
    }

    public void Remove(int id)
    {
        _songRepository.Remove(id);
    }

    public void Update(Song item, int id)
    {
        _songRepository.Update(_mapper.Map<SongData>(item), id);
    }

    public List<Song> Get(int count)
    {
        return _songRepository.Get(count)
            .Select(s => new Song()
            {
                Id = s.Id,
                Title = s.Title,
                Duration = s.Duration,
                Genre = s.Genre,
                Author = new Author()
                {
                    Name = s.Author.Name,
                }
            })
            .ToList();
    }
}

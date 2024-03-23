﻿using AutoMapper;
using BLL.Interfaces;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EFCoreRepo2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly SongService _songService;

        public MainWindow()
        {
            InitializeComponent();
            _songService = new SongService();
            dataGrid.ItemsSource = _songService.GetAll();
        }
    }
}
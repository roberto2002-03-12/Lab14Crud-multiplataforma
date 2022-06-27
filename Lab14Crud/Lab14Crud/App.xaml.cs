using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lab14Crud.DataContext;
using Lab14Crud.Interfaces;

namespace Lab14Crud
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            GetContext();
            MainPage = new MainPage();
        }

        public static AppDbContext GetContext()
        {
            string DbPath = DependencyService.Get<IConfigDataBase>().GetFullPath("efCore.db");

            return new AppDbContext(DbPath);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

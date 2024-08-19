using Note.Common.Models;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace Note.ViewModels
{
    public class MainViewModel:BindableBase
    {
        public  MainViewModel()
        {
            MenuBars = new ObservableCollection<MenuBar>();

        }

        private ObservableCollection<MenuBar> menuBars;
        public ObservableCollection<MenuBar> MenuBars
        {
            get { return menuBars; }
            set { menuBars = value;RaisePropertyChanged();}
        }

        void CreateMenuBar()
        {
            MenuBars.Add(new MenuBar() { Icon = "Home",Title = "首页",NameSapce = "IndexView"});
            MenuBars.Add(new MenuBar() { Icon = "NotebookOutline", Title = "待办事项", NameSapce = "ToDoView" });
            MenuBars.Add(new MenuBar() { Icon = "NotebookPlus", Title = "备忘录", NameSapce = "MemoView" });
            MenuBars.Add(new MenuBar() { Icon = "Cog", Title = "设置", NameSapce = "SettingView" });
        }
    }
}

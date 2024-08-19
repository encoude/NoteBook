using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note.Common.Models
{
	/// <summary>
	/// 导航系统实体类
	/// </summary>
    public class MenuBar:BindableBase
    {
		/// <summary>
		/// 菜单图标
		/// </summary>
		private String icon;

		public String Icon
		{
			get { return icon; }
			set { icon = value; }
		}
		/// <summary>
		/// 菜单名称
		/// </summary>
		private string title;

		public string Title
		{
			get { return title; }
			set { title = value; }
		}
        /// <summary>
        /// 菜单命名空间
        /// </summary>
        private String nameSpace;

		public String NameSapce
		{
			get { return nameSpace; }
			set { nameSpace = value; }
		}

	}
}

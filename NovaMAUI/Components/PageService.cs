using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Components;

namespace NovaMAUI.Share
{

    public class PageService
    {
        private Type _currentPage;

        // 获取或设置当前页面
        public Type CurrentPage
        {
            get => _currentPage;
            set
            {
                _currentPage = value;
                CurrentPageChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        // 当前页面更改事件
        public event EventHandler CurrentPageChanged;

        // 加载新页面
        public void LoadPage(Type pageType)
        {
            CurrentPage = pageType;
        }
    }
}

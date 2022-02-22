using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuleA.ViewModels;
using ModuleA.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleA
{
    public class ModuleAModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            IRegion region = regionManager.Regions["ContentRegion"];

            var tabA = containerProvider.Resolve<TabView>();
            SetTitle(tabA, "Tab A");
            region.Add(tabA);

            var tabB = containerProvider.Resolve<TabView>();
            SetTitle(tabB, "Tab B");
            region.Add(tabB);

            var tabC = containerProvider.Resolve<TabView>();
            SetTitle(tabC, "Tab C");
            region.Add(tabC);
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        void SetTitle(TabView tab, string title)
        {
            var context = tab.DataContext as TabViewModel;
            if (context != null)
            {
                context.Title = title;
            }
        }
    }
}

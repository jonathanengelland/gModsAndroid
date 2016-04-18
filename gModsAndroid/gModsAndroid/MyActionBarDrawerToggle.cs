using System;
using supportActionBarDrawerToggle = gModsAndroid.Support.V7.ActionBarDrawerToggle;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;

using Android.Support.V7.App;
using Android.Support.V4.Widget;

namespace gModsAndroid
{
    class MyActionBarDrawerToggle : supportActionBarDrawerToggle
    {
        private ActionBatActivity mHostActivity;
        private int mOpenedResource;
        private int mClosedResource;

        public MyActionBarDrawerToggle(ActionBarActivity host, DrawerLayout drawerLayout, int openedResources, int closeResurces) : base(host,drawerLayout,openedResources, closeResurces)
        {
            mHostActivity = host;
            mOpenedResource = openedResources;
            mClosedResource = closeResurces;
        }

        public override void OnDrawerOpened (Android.Views.View drawerView)
        {
            base.OnDrawerOpened(drawerView);
        }

        public override void OnDrawerClosed(Android.Views.View drawerView)
        {
            base.OnDrawerOpened(drawerView);
        }

        public override void OnDrawerSlide(Android.Views.View drawerView)
        {
            base.OnDrawerOpened(drawerView);
        }

    }
}
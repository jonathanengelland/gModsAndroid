using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using SupportToolbar = Android.Support.V7.Widget.Toolbar;
using Android.Support.V7.App;
using Android.Support.V4.Widget;

namespace gModsAndroid
{
    [Activity(Label = "gModsAndroid", MainLauncher = true, Icon = "@drawable/icon", Theme="@style/gMods")]
    public class MainActivity : ActionBarActivity
    {
        private SupportToolbar mToolbar;
        private MyActionBarDrawerToggle mDrawerToggel;
        private DrawerLayout mDrawerLayout;
        private ListView mLeftDrawer;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            mToolbar = FindViewById<SupportToolbar>(Resource.Id.toolbar);
            mDrawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_Layout);
            mLeftDrawer = FindViewById<ListView>(Resource.Id.left_drawer);

            SetSupportActionBar(mToolbar);

            mDrawerToggel = new MyActionBarDrawerToggle(
                this, //Host-Aktivität
                mDrawerLayout, //Drawer Layout
                Resource.String.openDrawer, //öffnet Nachricht 
                Resource.String.closeDrawer //schließt Nachricht 
                );
            mDrawerLayout.SetDrawerListener(mDrawerToggel); //sagt zum Drawer Toggel das er zuhören soll wenn es geöffnet und geschlossen wird und bearbeite das
            SupportActionBar.SetHomeButtonEnabled(true);
            SupportActionBar.SetDisplayShowTitelEnable(true);
            mDrawerToggel.SyncState(); //synct den Drawer Toggel mt dem DrawerLayout
        }

        public override bool OnOptionsItemSelected(IMenuItem item) //wird genutzt wenn ein Button gklickt wird anstatt dem Slide
        {
            mDrawerToggel.OnOptionsItemSelected(item);  //macht den button klickbar
            return base.OnOptionsItemSelected(item); 
        }
    }
}


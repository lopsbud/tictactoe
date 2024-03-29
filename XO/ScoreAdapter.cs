﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace XO
{
    class ScoreAdapter : BaseAdapter
    {
        Context context;
        List<ScoreClass> objects;

        public ScoreAdapter(Context context, List<ScoreClass> objects)
        {
            this.context = context;
            this.objects = objects;
        }

        public List<ScoreClass> GetList()
        {
            return this.objects;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;
            return view;
        }

        public override Java.Lang.Object GetItem(int position)
        {
            throw new NotImplementedException();
        }

        public override int Count
        {
            get
            {
                return 0;
            }
        }
    }
}
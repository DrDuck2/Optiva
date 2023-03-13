using System;
using System.Collections.Generic;
using System.Text;

namespace Ispit2019
{
    class YoutubeVideo
    {
        string mId;
        string mTitle;

        public YoutubeVideo(string mId,string mTitle)
        {
            this.mId = mId;
            this.mTitle = mTitle;
        }

        public string GetmId
        {
            get { return this.mId; }
        }
        public string GetmTitle
        {
            get { return this.mTitle; }
        }

        public static string[] mTitleArray(YoutubeVideo[] yv)
        {
            string[] stringera = new string[yv.Length];
            for (int i = 0; i < yv.Length; i++)
            {
                stringera[i] = yv[i].GetmTitle;
            }
            return stringera;
        }
    }
}

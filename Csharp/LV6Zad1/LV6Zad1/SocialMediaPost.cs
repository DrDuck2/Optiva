using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LV6Zad1
{
    class SocialMediaPost
    {
        private string accName;
        private string textMessage;
        private DateTime timeOfPosting;
        private HashSet<string> hashTags;

        public SocialMediaPost(string accName,string textMessage)
        {
            this.accName = accName;
            this.textMessage = textMessage;
            this.timeOfPosting = DateTime.Now;
            this.hashTags = new HashSet<string>();
        }

        public SocialMediaPost(SocialMediaPost previousPost)
        {
            accName = previousPost.accName;
            textMessage = previousPost.textMessage;
            timeOfPosting = previousPost.timeOfPosting;
            hashTags = new HashSet<string>();
            hashTags.UnionWith(previousPost.hashTags);
        }

        public void Tag(string hashtag)
        {
            this.hashTags.Add(hashtag);
        }

        public void Untag(string hashtag)
        {
            if(this.hashTags.Contains(hashtag))
            {
                this.hashTags.Remove(hashtag);
            }
        }

        public override string ToString()
        {
            return $"{this.timeOfPosting} Ime: {this.accName}{Environment.NewLine}Message: {this.textMessage}{Environment.NewLine}HashTags:{HashTagsString()}";
        }
        
        public string HashTagsString()
        {
            string output = string.Empty;
            foreach(var element in this.hashTags)
            {
                output += $"{element} ";
            }
            return output;
        }


    }
}

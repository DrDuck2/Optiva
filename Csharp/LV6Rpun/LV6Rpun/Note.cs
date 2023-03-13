using System;
using System.Collections.Generic;
using System.Text;

namespace LV6Rpun
{
    public class Note
    {
        public string Title { get; private set; }
        public string Text { get; private set; }
        public Note(string title, string text)
        {
            this.Title = title;
            this.Text = text;
        }
        private int GetFrameWidth()
        {
            return
            this.Title.Length < this.Text.Length ? this.Text.Length : this.Title.Length;
        }
        private string GetRule(char c) { return new string(c, this.GetFrameWidth()); }
        public void Show()
        {
            Console.WriteLine(this.GetRule('='));
            Console.WriteLine(this.Title);
            Console.WriteLine(this.GetRule('-'));
            Console.WriteLine(this.Text);
            Console.WriteLine(this.GetRule('='));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LV5Rpon
{
    public class GroupNote : Note
    {
        private List<string> memberNames;
        public GroupNote(string message, ITheme theme) : base(message, theme) 
        {
            memberNames = new List<string>();
        }

        public void AddMember(string name)
        {
            this.memberNames.Add(name);
        }

        public void RemoveMember(string name)
        {
            this.memberNames.Remove(name);
        }
        public string GetMemberNames()
        {
            return String.Join(",", memberNames);
        }
        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine("FORTHEGROUP: ");
            string framedMessage = this.GetFramedMessage();
            Console.WriteLine(framedMessage);
            Console.WriteLine($"Members: {this.GetMemberNames()}");
            Console.ResetColor();
        }
    }
}

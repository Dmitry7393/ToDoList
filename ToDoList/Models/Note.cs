using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class Note
    {
        public static List<Note> mListNotes = new List<Note>();
        //ID note
        public int Id { get; set; }
        //Note
        public string Data { get; set; }
        //post date
        public string PostDate { get; set; }
    }
}
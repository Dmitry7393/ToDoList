using System;
using System.Web.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(Note.mListNotes);
        }
       
        public ActionResult AddNote(Note note)
        {
            if (note.Data != null)
            {
                note.PostDate = DateTime.Now.ToString();
                Note.mListNotes.Add(note);
            }
            return PartialView("PartialViewNotes", Note.mListNotes);
        }
        
        public ActionResult UpdateList(string note, string rowInTable)
        {
            int index = getIndexList(Convert.ToInt32(rowInTable));
            Note.mListNotes[index].Data = note;
            return PartialView("PartialViewNotes", Note.mListNotes);
        }
        
        public ActionResult DeleteNote(string rowInTable)
        {
            int index = getIndexList(Convert.ToInt32(rowInTable));
            Note.mListNotes.RemoveAt(index);
            return PartialView("PartialViewNotes", Note.mListNotes);
        }
        private int getIndexList(int rowInTable)
        {
            return Note.mListNotes.Count - Convert.ToInt32(rowInTable);
        }
    }
}
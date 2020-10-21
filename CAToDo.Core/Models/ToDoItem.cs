using System;

namespace CAToDo.Core.Models
{
    public class ToDoItem
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public bool Completed { get; set; }

        public DateTime Created { get;  private set; }

        public DateTime LastUpdated { get; set; }

        public ToDoItem()
        {
            // Fill in the default fields
            this.Completed = false;
            this.Created = DateTime.UtcNow;
            this.LastUpdated = this.Created;
        }

        public ToDoItem(string title, string description)
        {
            // Fill in the default fields
            this.Created = DateTime.UtcNow;
            this.LastUpdated = this.Created;
            this.Completed = false;

            // Fill in user defined fields
            this.Description = description;
            this.Title = title;
        }
    }
}

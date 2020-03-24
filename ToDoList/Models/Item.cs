using System.Collections.Generic;
using System;

namespace ToDoList.Models
{
  public class Item
  {
    public Item()
    {
      this.Categories = new HashSet<CategoryItem>();
    }

    public int ItemId { get; set; }
    public string Description { get; set; }
    public bool Completed { get; set; }
    public DateTime Date { get; set; }
    public virtual ApplicationUser User { get; set; }

    public ICollection<CategoryItem> Categories { get;}

  }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Core;

public class WorkTaskViewModel
{
    public string Title { get; set; }
    public string Description { get; set; }

    public DateTime CreatedDate { get; set; }
}

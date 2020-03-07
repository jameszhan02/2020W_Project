using System;
using System.Collections.Generic;
using System.Text;

namespace project_SSG
{
    class Task
    {
        string content { get; set; }
        string id { get; set; }
        string parent { get; set; } = null;
        string backlog { get; set; } = "";
    }
}

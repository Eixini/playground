using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaMvvmApp.Models;

public class DataGridItem {
    public string? Name { get; set; }
    public string? Nickname { get; set; }
    public string? Description { get; set; }

    public DataGridItem(string name, string nickname, string description) {
        Name = name;
        Nickname = nickname;
        Description = description;
    }

}

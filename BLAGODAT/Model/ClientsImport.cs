using System;
using System.Collections.Generic;

namespace BLAGODAT.Model;

public partial class ClientsImport
{
    public int КодКлиента { get; set; }

    public string Фио { get; set; } = null!;

    public string ПаспортныеДанные { get; set; } = null!;

    public string ДатаРождения { get; set; } = null!;

    public string Адрес { get; set; } = null!;

    public string EMail { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<OrderImport> OrderImports { get; set; } = new List<OrderImport>();
}

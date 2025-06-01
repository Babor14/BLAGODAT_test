using System;
using System.Collections.Generic;

namespace BLAGODAT.Model;

public partial class ServicesImport
{
    public int Id { get; set; }

    public string НаименованиеУслуги { get; set; } = null!;

    public string КодУслуги { get; set; } = null!;

    public decimal СтоимостьРубЗаЧас { get; set; }

    public virtual ICollection<OrderImport> IdЗаказаs { get; set; } = new List<OrderImport>();
}

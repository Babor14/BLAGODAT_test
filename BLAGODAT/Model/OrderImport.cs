using System;
using System.Collections.Generic;

namespace BLAGODAT.Model;

public partial class OrderImport
{
    public int Id { get; set; }

    public string КодЗаказа { get; set; } = null!;

    public string ДатаСоздания { get; set; } = null!;

    public string ВремяЗаказа { get; set; } = null!;

    public int КодКлиента { get; set; }

    public string Статус { get; set; } = null!;

    public string? ДатаЗакрытия { get; set; }

    public string ВремяПроката { get; set; } = null!;

    public virtual ClientsImport КодКлиентаNavigation { get; set; } = null!;

    public virtual ICollection<ServicesImport> КодУслугиs { get; set; } = new List<ServicesImport>();
}

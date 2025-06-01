using System;
using System.Collections.Generic;

namespace BLAGODAT.Model;

public partial class WorkersImport
{
    public int КодСотрудника { get; set; }

    public string Должность { get; set; } = null!;

    public string Фио { get; set; } = null!;

    public string Логин { get; set; } = null!;

    public string Пароль { get; set; } = null!;

    public string? ПоследнийВход { get; set; }

    public string ТипВхода { get; set; } = null!;
}

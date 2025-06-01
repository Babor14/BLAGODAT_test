using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BLAGODAT.Model;

public partial class GorcompContext : DbContext
{
    public GorcompContext()
    {
    }

    public GorcompContext(DbContextOptions<GorcompContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ClientsImport> ClientsImports { get; set; }

    public virtual DbSet<OrderImport> OrderImports { get; set; }

    public virtual DbSet<ServicesImport> ServicesImports { get; set; }

    public virtual DbSet<WorkersImport> WorkersImports { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-SG41KID\\SQLEXPRESS;Initial Catalog=GORCOMP;Integrated Security=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ClientsImport>(entity =>
        {
            entity.HasKey(e => e.КодКлиента).HasName("PK__Clients___FDED6CB150EB7A14");

            entity.ToTable("Clients_import");

            entity.Property(e => e.КодКлиента)
                .ValueGeneratedNever()
                .HasColumnName("Код клиента");
            entity.Property(e => e.EMail)
                .HasMaxLength(100)
                .HasColumnName("e-mail");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Адрес).HasMaxLength(255);
            entity.Property(e => e.ДатаРождения)
                .HasMaxLength(100)
                .HasColumnName("Дата рождения");
            entity.Property(e => e.ПаспортныеДанные)
                .HasMaxLength(100)
                .HasColumnName("Паспортные данные");
            entity.Property(e => e.Фио)
                .HasMaxLength(100)
                .HasColumnName("ФИО");
        });

        modelBuilder.Entity<OrderImport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Order_im__3214EC27181128BC");

            entity.ToTable("Order_import");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ВремяЗаказа)
                .HasMaxLength(100)
                .HasColumnName("Время заказа");
            entity.Property(e => e.ВремяПроката)
                .HasMaxLength(50)
                .HasColumnName("Время проката");
            entity.Property(e => e.ДатаЗакрытия)
                .HasMaxLength(100)
                .HasColumnName("Дата закрытия");
            entity.Property(e => e.ДатаСоздания)
                .HasMaxLength(100)
                .HasColumnName("Дата создания");
            entity.Property(e => e.КодЗаказа)
                .HasMaxLength(50)
                .HasColumnName("Код заказа");
            entity.Property(e => e.КодКлиента).HasColumnName("Код клиента");
            entity.Property(e => e.Статус).HasMaxLength(50);

            entity.HasOne(d => d.КодКлиентаNavigation).WithMany(p => p.OrderImports)
                .HasForeignKey(d => d.КодКлиента)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Заказы_Клиенты");

            entity.HasMany(d => d.КодУслугиs).WithMany(p => p.IdЗаказаs)
                .UsingEntity<Dictionary<string, object>>(
                    "OrderService",
                    r => r.HasOne<ServicesImport>().WithMany()
                        .HasForeignKey("КодУслуги")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ЗаказыУслуги_Услуги"),
                    l => l.HasOne<OrderImport>().WithMany()
                        .HasForeignKey("IdЗаказа")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ЗаказыУслуги_Заказы"),
                    j =>
                    {
                        j.HasKey("IdЗаказа", "КодУслуги");
                        j.ToTable("Order_Services");
                        j.IndexerProperty<int>("IdЗаказа").HasColumnName("ID заказа");
                        j.IndexerProperty<int>("КодУслуги").HasColumnName("Код услуги");
                    });
        });

        modelBuilder.Entity<ServicesImport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Services__3214EC27EDEDE646");

            entity.ToTable("Services_import");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.КодУслуги)
                .HasMaxLength(50)
                .HasColumnName("Код услуги");
            entity.Property(e => e.НаименованиеУслуги)
                .HasMaxLength(100)
                .HasColumnName("Наименование услуги");
            entity.Property(e => e.СтоимостьРубЗаЧас)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Стоимость, руб. за час");
        });

        modelBuilder.Entity<WorkersImport>(entity =>
        {
            entity.HasKey(e => e.КодСотрудника).HasName("PK__Workers___6B9F1565319FE89D");

            entity.ToTable("Workers_import");

            entity.Property(e => e.КодСотрудника)
                .ValueGeneratedNever()
                .HasColumnName("Код сотрудника");
            entity.Property(e => e.Должность).HasMaxLength(50);
            entity.Property(e => e.Логин).HasMaxLength(100);
            entity.Property(e => e.Пароль).HasMaxLength(50);
            entity.Property(e => e.ПоследнийВход)
                .HasMaxLength(100)
                .HasColumnName("Последний вход");
            entity.Property(e => e.ТипВхода)
                .HasMaxLength(20)
                .HasColumnName("Тип входа");
            entity.Property(e => e.Фио)
                .HasMaxLength(100)
                .HasColumnName("ФИО");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

using System;
using System.Collections.Generic;
/// <summary>
/// Ювелирное изделие
/// </summary>
public class Jewelry
{
    /// <summary>
    /// Дата поступления
    /// </summary>
    public DateTime Receipt { get; set; }
    /// <summary>
    /// Работа с ювелирным изделием
    /// </summary>
    public List<RepairAndCleaning> RepairAndCleaningProducts { get; set; }
    /// <summary>
    /// Тип металла
    /// </summary>
    public MetType MetType { get; set; }
    /// <summary>
    /// Описание изделия
    /// </summary>
    public List<Filling> Description { get; set; }
    /// <summary>
    /// Фотография
    /// </summary>
    public byte[] Photo { get; set; }
}

/// <summary>
/// Заполнение
/// </summary>
public class Filling
{
    /// <summary>
    /// Артикуль
    /// </summary>
    public string Artikul { get; set; }
    /// <summary>
    /// Заказчик
    /// </summary>
    public string Customer { get; set; }
    /// <summary>
    /// Когда будет готово
    /// </summary>
    public string IsDone { get; set; }
    /// <summary>
    /// Стоимость
    /// </summary>
    public string CostOf { get; set; }
}

/// <summary>
/// Тип металла
/// </summary>
public enum MetType
{
    /// <summary>
    /// Золото
    /// </summary>
    Gold,
    /// <summary>
    /// Серебро
    /// </summary>
    Silver,
    /// <summary>
    /// Бижутерия
    /// </summary>
    Bijouterie,
}

/// <summary>
/// Ремонт и чистка изделий
/// </summary>
public class RepairAndCleaning
{
    /// <summary>
    /// Выбор услуги
    /// </summary>
    public string Serviceselection { get; set; }
    /// <summary>
    /// Дата записи на ремонт
    /// </summary>
    public DateTime ServiceseDate { get; set; }

    /// <summary>
    /// Ожидаемая дата готовности
    /// </summary>
    public DateTime? ExpectedAvailabilityDate { get; set; }

    /// <summary>
    /// Описание работ
    /// </summary>
    public string Description { get; set; }
}
using System.Globalization;

Console.Clear();

//var data = new DateTime(2024, 09, 20, 12, 0, 14); // Criando uma data personalizada
var date = DateTime.Now;

// Metodos de exibição de data
Console.WriteLine(date);
Console.WriteLine(date.Year);
Console.WriteLine(date.Month);
Console.WriteLine(date.Day);
Console.WriteLine(date.Hour);
Console.WriteLine(date.Minute);
Console.WriteLine(date.Second);
Console.WriteLine(date.DayOfWeek);

// Algumas opções para personalização de data
var formatDate = String.Format("{0:yyyy-MM-dd hh:mm:ss}", date); // Formatação personalizada
Console.WriteLine(formatDate);

formatDate = String.Format("{0:r}", date); // r, s, u normalmente são padrões de alguns bancos de dados
Console.WriteLine(formatDate);

// Métodos para incremento de datas
Console.WriteLine(date);

Console.WriteLine(date.AddDays(12));

Console.WriteLine(date.AddMonths(1));

Console.WriteLine(date.AddYears(1));

// Globalização
var pt = new CultureInfo("pt-PT");
var br = new CultureInfo("pt-BR");
var en = new CultureInfo("en-US");
var de = new CultureInfo("de-DE");

Console.WriteLine(DateTime.Now.ToString("D", pt));
Console.WriteLine(DateTime.Now.ToString("D", de));

var atual = CultureInfo.CurrentCulture; // Pegar a data e horário da máquina
var utcDate = DateTime.UtcNow; // Pegar a data e horário global

Console.WriteLine(DateTime.Now);
Console.WriteLine(utcDate);
Console.WriteLine(utcDate.ToLocalTime()); // Convertendo para o horário da máquina

var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland"); // Pegando o timezone da Austrália
Console.WriteLine(timezoneAustralia);

var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia); // Convertento um horário global para o horário da Austrália
Console.WriteLine(horaAustralia);

// Listando todos os timezones
var timezones = TimeZoneInfo.GetSystemTimeZones();
foreach (var timezone in timezones)
{
  Console.WriteLine(timezone.Id);
  Console.WriteLine(timezone);
  Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
  Console.WriteLine("__________");
}

// TimeSpan é utilizado para fazer cálculo de horas, por exemplo folha de ponto
var timeSpan = new TimeSpan();
Console.WriteLine(timeSpan);

var timeSpanNanosegundos = new TimeSpan(1);
Console.WriteLine(timeSpanNanosegundos);

var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
Console.WriteLine(timeSpanHoraMinutoSegundo);

var timeSpanDiaHoraMinutoSegundo = new TimeSpan(15, 5, 12, 8);
Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(15, 5, 12, 8, 100);
Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));

// Quantos dias tem o mês?
Console.WriteLine(DateTime.DaysInMonth(2024, 9));

// É fim de semana?
Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));

static bool IsWeekend(DayOfWeek today)
{
  return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
}

// É horário de verão?
Console.WriteLine(DateTime.Now.IsDaylightSavingTime());


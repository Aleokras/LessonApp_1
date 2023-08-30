// See https://aka.ms/new-console-template for more information
ConverterHourToMinutesAndSeconds(77.5);
ConverterMeterToСentimetersAndMillimeters(44.560);



void ConverterHourToMinutesAndSeconds(double hour)
{
    Console.WriteLine($"{hour * 60}: minutes");
    Console.WriteLine($"{hour * 3600}: seconds");
}


void ConverterMeterToСentimetersAndMillimeters(double meter)

{
    Console.WriteLine();
    Console.WriteLine($"{meter * 100}: centimeters");
    Console.WriteLine($"{meter * 1000}: millimeters");
}

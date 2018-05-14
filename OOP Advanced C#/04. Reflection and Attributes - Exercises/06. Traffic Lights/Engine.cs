using System;
using System.Collections.Generic;
using System.Text;

public class Engine
{
    public void Run()
    {
        var devices = this.SetTrafficLightsDevices();
        var numberofLightChanges = int.Parse(Console.ReadLine());
        Console.WriteLine(this.ChangeLights(devices, numberofLightChanges));
    }

    private string ChangeLights(Queue<TrafficLight> devices, int numberofLightChanges)
    {
        var sb = new StringBuilder();

        while (numberofLightChanges > 0)
        {
            foreach (var device in devices)
            {
                device.ChangeLight();
                sb.Append($"{device.Light} ");
            }

            sb.Remove(sb.Length - 1, 1).AppendLine();
            numberofLightChanges--;
        }

        return sb.ToString().Trim();
    }

    private Queue<TrafficLight> SetTrafficLightsDevices()
    {
        var lightDevicesFromInput = Console.ReadLine().Split();
        var devices = new Queue<TrafficLight>();

        foreach (var lightAsString in lightDevicesFromInput)
        {
            TLightColor light;
            var isValid = Enum.TryParse(lightAsString, out light);

            if (isValid)
            {
                devices.Enqueue(new TrafficLight(light));
            }
        }

        return devices;
    }
}

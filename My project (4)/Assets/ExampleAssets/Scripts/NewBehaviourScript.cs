using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
*/
public class Main{
    public static void main(string[] args)
    {
        Console.WriteLine(".");
    }
}
interface Device
{

    int GetDeviceId();
    void GetInfo();
    string GetDeviceData();
}

public class Definition : Device
{
    public int idDevice;
    private string namedevice;
    private string nameDevice;
    Boolean status;
    public Definition(int idDevice, string namedevice) {
        this.idDevice = idDevice;
        this.namedevice = namedevice;
    }

    public int GetDeviceId(Definition obj)
    {
        return obj.idDevice;
    }

    public void GetInfo(Definition obj)
    {
        Console.WriteLine("info device : " + idDevice + " "+nameDevice);
    }
    public string GetDeviceData(Definition obj)
    {
        if (obj is null)
        {
            throw new ArgumentNullException(nameof(obj));
        }

    }
}

public class Image{
    public object Size { get; private set; }
    public int Width { get; private set; }
    public int Height { get; private set; }

    public bool Equalit(Image Image_1, Image Image_2)
    {
        Image standart_1 = (Image)Image_1;
        Image standart_2 = (Image)Image_2;
        if (standart_1.Size == standart_2.Size)
        {
            for (int i = 0; i < standart_1.Width; i++)
                for (int j = 0; j < standart_1.Height; j++)
                    if (standart_1.GetPixel(Image_1) != standart_2.GetPixel(Image_2)) return false;
            return true;
        }
        else return false;
    }

    private object GetPixel(Image image)
    {
        return image.Width * image.Height;
    }
}
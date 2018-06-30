using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtintionsHelper
{

    string[] ImageTypes = { ".jpg", ".png" };

    ExtintionsHelper()
    {

    }

    public FileType ParseExtention(string url)
    {
        foreach (var ext in ImageTypes)
        {
            if (url.EndsWith(ext))
            {
                return FileType.Image;
            }
        }
        return FileType.file;
    }

}


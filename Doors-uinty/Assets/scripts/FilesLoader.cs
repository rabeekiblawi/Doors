
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UniRx;
using System;

namespace Utils
{
    public class FilesLoader
    {
        public WWW LoadFile(string url)
        {
            WWW file = default(WWW);
            var raw = Observable.WhenAll(ObservableWWW.GetWWW(url));
            raw.Subscribe(www =>
            {
                file = www[0];
            });
            return file;
        }
    }
}
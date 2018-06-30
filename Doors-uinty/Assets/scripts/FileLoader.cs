
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UniRx;
using System;

namespace Utils
{
    public sealed class FileLoader
    {
        static FileLoader instance = new FileLoader();
        private FileLoader() { }
        public static FileLoader Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FileLoader();
                }
                return instance;
            }
        }

        public IObservable<WWW[]> LoadFile(string url)
        {
            return Observable.WhenAll(ObservableWWW.GetWWW(url));
        }

    }
}
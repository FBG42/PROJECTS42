using System;

namespace diamante.devices
{
    public abstract class device
    {
        public int serialNumber { get; set; }

        public abstract void processDoc(string document);
    }
}

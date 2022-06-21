using System;

namespace Adapter
{
    class Computer
    {
        private UsbType product;

        public void connect(UsbType product)
            => this.product = product;

        public void printData()
            => Console.WriteLine(product.getData());
    }
}

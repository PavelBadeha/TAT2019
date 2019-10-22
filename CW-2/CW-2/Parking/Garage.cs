using Newtonsoft.Json;

namespace CW_2
{
    class Garage
    {
        [JsonProperty]
        public int QuantityOfSlots { get; private set; }

        public Garage() { } 

        public Garage(int quantityOfSlots)
        {
            QuantityOfSlots = quantityOfSlots;
        }
        public override string ToString()
        {
            return "Quantity Of Slots:"+QuantityOfSlots;
        }
    }
}

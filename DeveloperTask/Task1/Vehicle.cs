namespace DeveloperTask.Task1
{
    internal abstract class Vehicle
    {
        private float _topSpeed;
        private int _passengerCount;
        
        public virtual float TopSpeed {
            get 
            { 
                return _topSpeed;  
            } 
            set 
            {
                if (value < 0.0)
                {
                    throw new ArgumentException($"Vehicle speed can't be lower than 0.0, {value} was provided");
                }
                else 
                {
                    _topSpeed = value;
                }
            } 
        }
        
        public virtual string? Name { get; set; }
        
        public virtual int PassengerCount 
        {
            get
            {
                return _passengerCount;
            }
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException($"Vehicle speed can't be lower than 0, {value} was provided");
                }
                else 
                {
                    _passengerCount = value;
                }
            }
        }

        protected Vehicle() 
        {
        }

        protected Vehicle(float topSpeed, string name, int passengerCount):this()
        {
            TopSpeed = topSpeed;
            Name = name;
            PassengerCount = passengerCount;
        }
    }
}

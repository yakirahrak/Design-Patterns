using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    public abstract class CarFactory
    {
        public Tin CreateTin()
        {
            return new Tin();
        }

        public Wheels CreateWheels()
        {
            return new Wheels();
        }

        public Seats CreateSeats()
        {
            return new Seats();
        }

        public abstract EngineBase CreateEngine();
        public abstract ACBase CreateAC();
        public abstract LightSystemBase CreateLightSystem();
        public abstract BateryBase CreateBatery();
    }
    public class NormalCarFactory : CarFactory
    {
        public override ACBase CreateAC()
        {
            return new NormalAC();
        }

        public override BateryBase CreateBatery()
        {
            return new NormalBatery();
        }

        public override EngineBase CreateEngine()
        {
            return new NormalEngine();
        }

        public override LightSystemBase CreateLightSystem()
        {
            return new NormalLightSystem();
        }
    }

    public class HybridCarFactory:CarFactory
    {
        public override ACBase CreateAC()
        {
            return new HybridAC();
        }

        public override BateryBase CreateBatery()
        {
            return new HybridBatery();
        }

        public override EngineBase CreateEngine()
        {
            return new HybridEngine();
        }

        public override LightSystemBase CreateLightSystem()
        {
            return new HybridLightSystem();
        }
    }
}


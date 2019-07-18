using System;
using System.Collections.Generic;
using System.Text;

namespace ElevatorProject
{
    public class Elevator
    {
        public string Name { get; set; }
        public int CurrentFloor { get; set; }
        public int LowestFloor { get; set; }
        public int HighetstFloor { get; set; }
        public int UntilMaintainance { get; set; }
        public bool PowerIsOn { get { return UntilMaintainance < 1 ? false : true; } }

        public enum ElevatorMoveResponse
        {
            Success, NoPower, CantGoDown, CantGoUp
        }
        public Elevator()
        {

        }

        public Elevator(string name, int startFloor, int lowestFloor, int highestFloor, int untilMaintainance)
        {
            Name = name;
            CurrentFloor = startFloor;
            LowestFloor = lowestFloor;
            HighetstFloor = highestFloor;
            UntilMaintainance = untilMaintainance;

        }

        public ElevatorMoveResponse TryGoUp(int floors = 1)
        {
            if (UntilMaintainance == 0)
                return ElevatorMoveResponse.NoPower;

            if (CurrentFloor + floors > HighetstFloor)
            {
                int move = HighetstFloor - CurrentFloor;
                CurrentFloor = HighetstFloor;
                UntilMaintainance -= move;
                return ElevatorMoveResponse.CantGoUp;
            }
            else
            {
                CurrentFloor += floors;
                UntilMaintainance -= floors;
                return ElevatorMoveResponse.Success;
            }
        }
        public ElevatorMoveResponse TryGoDown(int floors = 1)
        {
            if (UntilMaintainance == 0)
                return ElevatorMoveResponse.NoPower;
            if (UntilMaintainance - floors == 0)
            {

                return ElevatorMoveResponse.NoPower;
            }
            if (CurrentFloor - floors < LowestFloor)
            {
                int move = CurrentFloor - LowestFloor;
                CurrentFloor = LowestFloor;
                UntilMaintainance -= move;
                return ElevatorMoveResponse.CantGoDown;
            }
            else
            {
                CurrentFloor -= floors;
                UntilMaintainance -= floors;

                return ElevatorMoveResponse.Success;
            }
        }
        public void DoMaintainanceOnElevator()
        {
            UntilMaintainance += 30;
        }

    }


}

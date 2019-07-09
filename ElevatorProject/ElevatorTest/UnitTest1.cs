using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElevatorProject;
using static ElevatorProject.Elevator;

namespace ElevatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void elevator_should_be_at_level_1_when_it_starts_at_0_and_go_up_one_floor()
        {
            // ARRANGE
            var x = new Elevator("e1", 0, -2, 10, 3);
            // ACT
            x.TryGoUp();
            // ASSERT
            Assert.AreEqual(1, x.CurrentFloor);
        }

        [TestMethod]
        public void elevator_should_be_at_level_negative_1_when_it_starts_at_0_and_go_down_one_floor()
        {
            // ARRANGE
            var x = new Elevator("e1", 0, -2, 10, 3);
            // ACT
            x.TryGoDown();
            // ASSERT
            Assert.AreEqual(-1, x.CurrentFloor);
        }

        [TestMethod]
        public void elevator_should_not_go_down_when_it_starts_at_negative_2_and_go_down_one_floor()
        {
            // ARRANGE
            var x = new Elevator("e1", -2, -2, 10, 3);
            // ACT
            ElevatorMoveResponse result = x.TryGoDown();
            ElevatorMoveResponse expected = ElevatorMoveResponse.CantGoDown;

            // ASSERT
            Assert.AreEqual(expected, result);
            Assert.AreEqual(-2, x.CurrentFloor);
        }

        [TestMethod]
        public void elevator_should_not_go_up_when_it_starts_at_10_and_go_up_one_floor()
        {
            // ARRANGE
            var x = new Elevator("e1", 10, -2, 10, 3);

            // ACT
            ElevatorMoveResponse result = x.TryGoUp();
            ElevatorMoveResponse expected = ElevatorMoveResponse.CantGoUp;

            // ASSERT
            Assert.AreEqual(expected, result);
            Assert.AreEqual(10, x.CurrentFloor);
        }

        [TestMethod]
        public void elevator_should_not_move_when_power_is_off()
        {
            // ARRANGE
            var x = new Elevator("e1", 0, -2, 10, 0);
            // ACT
            ElevatorMoveResponse result = x.TryGoDown();
            ElevatorMoveResponse expected = ElevatorMoveResponse.NoPower;

            // ASSERT
            Assert.AreEqual(expected, result);
            Assert.AreEqual(0, x.CurrentFloor);
        }

        [TestMethod]
        public void elevator_should_be_at_level_10_when_it_starts_at_0_and_go_up_10_floors()
        {
            // ARRANGE
            var x = new Elevator("e1", 0, -2, 10, 3);
            // ACT
            x.TryGoUp(10);
            // ASSERT
            Assert.AreEqual(10, x.CurrentFloor);
        }

        [TestMethod]
        public void elevator_should_be_at_level_negative_1_when_it_starts_at_5_and_go_down_6_floors()
        {
            // ARRANGE
            var x = new Elevator("e1", 5, -2, 10, 3);
            // ACT
            x.TryGoDown(6);
            // ASSERT
            Assert.AreEqual(-1, x.CurrentFloor);
        }
    }
}

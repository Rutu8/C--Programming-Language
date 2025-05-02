using HierarchicalInheritance;

Car cars = new Car();
cars.startengine();
cars.getcar();

motorCycle cycle = new motorCycle();
cycle.startengine();
cycle.getmotor();

Truck truck = new Truck();
truck.startengine();
truck.gettruck();

cars.displaycar();
cycle.displaymotor();
truck.displaytruck();
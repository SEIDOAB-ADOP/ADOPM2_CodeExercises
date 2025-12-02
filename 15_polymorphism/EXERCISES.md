# Inheritance and Polymorphism Exercises

Based on the existing `Animal` and `Zoo` classes in the Models folder.

---

## Part 1: Inheritance Exercises

### Exercise 1: Create NordicAnimal Class

1. Create a class `NordicAnimal` that inherits from `Animal`
2. Add a property `Kind` of type `NordicAnimalKind`
3. Add a property `CanSwim` of type `bool`
4. Override the `ToString()` method to include the kind and swimming ability
5. Implement the `Seed()` method to also seed the new properties
6. Add a copy constructor that calls the base copy constructor
7. Create a seeded instance and have it present itself using `ToString()`

**Expected Output Example:**
```
"Max the Happy Wolf 3yr, Can swim: true"
```

---

### Exercise 2: Create AfricanAnimal Class

1. Create a class `AfricanAnimal` that inherits from `Animal`
2. Add a property `Kind` of type `AfricanAnimalKind`
3. Add a property `WeightKg` of type `decimal`
4. Override the `ToString()` method to include kind and weight
5. Implement the `Seed()` method to seed all properties (weight between 50-5000 kg)
6. Add a copy constructor
7. Create a seeded instance and have it present itself using `ToString()`

**Expected Output Example:**
```
"Simba the Lazy Lion 5yr, Weight: 190.5 kg"
```

---

### Exercise 3: Create HunterBird Class
1. Create a class `HunterBird` that inherits from `Animal`
2. Add a property `Kind` of type `HunterBirdKind`
3. Add a property `WingspanCm` of type `int`
4. Add a property `CanHuntAtNight` of type `bool`
5. Override the `ToString()` method
6. Implement the `Seed()` method (wingspan between 50-250 cm)
7. Add a copy constructor
8. Implement method chaining by creating these methods that return `HunterBird`:
   - `Hunt()` - sets Mood to Quick and returns the instance
   - `Fly()` - changes Mood to Happy and returns the instance
   - `Rest()` - changes Mood to Sleepy and returns the instance
9. Test the method chaining: `bird.Hunt().Fly().Rest()`
10. Create a seeded instance and have it present itself using `ToString()`

**Expected Output Example:**
```
"Milo the Quick Eagle 2yr, Wingspan: 180cm, Night hunter: false"

Method chaining example:
var bird = new HunterBird().Seed(seeder);
bird.Hunt().Fly().Rest();
// Bird's mood changes: Quick -> Happy -> Sleepy
```

---

## Part 2: Polymorphism Exercises

### Exercise 4: Polymorphic Zoo Collection
**Objective:** Understand polymorphism with heterogeneous collections.

**Task:**
1. In `Program.cs`, create a `Zoo` instance
2. Create at least 5 instances of `NordicAnimal`, `AfricanAnimal`, and `HunterBird` each using the Seed method seeder.ItemsToList<...>()
3. Add each type to the Zoo's `ListOfAnimal` collection
4. Display all animals using the Zoo's `ToString()` method
5. Observe how each animal type displays differently despite being stored as `Animal` references

**Questions to answer:**
- What allows different animal types to be stored in the same list?
- Why does each animal display its specific information despite being in a `List<Animal>`?

---

### Exercise 5: Virtual Methods and Method Overriding
**Objective:** Implement virtual methods to demonstrate polymorphism.

**Task:**
1. In the `Animal` base class, add a virtual method `MakeSound()` that returns "Generic animal sound"
2. In `NordicAnimal`, override `MakeSound()` to return different sounds based on `Kind`:
   - Wolf: "Howl!"
   - Bear: "Roar!"
   - Moose: "Bellow!"
   - Others: "Animal sound..."
3. In `AfricanAnimal`, override `MakeSound()` based on its `Kind`:
   - Lion: "Roar!"
   - Elephant: "Trumpet!"
   - Monkey: "Screech!"
   - Others: "Animal sound..."
4. In `HunterBird`, override `MakeSound()` to return "Screech!" for all birds
5. In `Program.cs`, iterate through the Zoo's animals and call `MakeSound()` on each
6. Print both the animal's ToString() and MakeSound() output

**Expected Output Example:**
```
Milo the Happy Wolf 3yr, Can swim: true - Sound: Howl!
Simba the Lazy Lion 5yr, Weight: 190.5 kg - Sound: Roar!
Max the Quick Eagle 2yr, Wingspan: 180cm - Sound: Screech!
```

---

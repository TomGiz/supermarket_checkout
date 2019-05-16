# Overview
This is code for the Supermarket Checkout kata.
I used it to train unit testing and test-driven development to the team.

# Resources:
 * https://github.com/asierba/Katas.CSharp
 * https://github.com/asierba/Katas.CSharp/tree/master/Checkout
 * http://codekata.com/kata/kata01-supermarket-pricing/

# Introduction

## What is a kata? 
(from http://codekata.com/kata/kata01-supermarket-pricing/)

Code kata = 
 * exercise for developers, just like a kata in karate.
 * simple, artificial exercises 
 * lets us experiment and learn without the pressure of a production environment and deadlines

How to kata
 * find a place and time where you won't be interrupted
 * focus on the essential elements of the kata
 * remember to look for feedback for every major decision
 * if it helps, keep a journal of your progress
 * have discussion groups with other developers, but try to have completed the kata first

## What are TDD and pair programming?

### TDD = Test-Driven Development

Short development cycle
 1. Add a test
    * New requirement = new test 
	* focus on requirements before writing the code 
 2. Run all tests and see if the new test fails
	* test the test 
 3. Write the code 
	* minimum viable implementation
	* the code should not be elegant (focus on this later on)
 4. Run all tests
	* new requirement implemented
	* did not break any other tests 
 5. Refactor
	* clean up  growing code base
	* remove duplication
	* clean/readable code 

### Pair programming 
 * 2 developers, one PC
 * 2 roles
	 * _driver_ writes code 
	 * _observer_ or _navigator_ reviews each line being typed
	 * switch roles frequently
 * advantages
    - fewer defects
	- shared knowledge of the code 
	- design quality
	- developer satisfaction
 * disadvantage
	- development time/cost rises 


# Schedule for this kata

0. Setup
	* Visual Studio projects
	* Xunit
	* each group is given an ordinal number
	*

 1. Start

    * In our supermarket, we need to calculate the total price of all items that are scanned at checkout.
    * Products are identified by a SKU (Stock Keeping Unit).
    * For sake of simplicity, we will use letter (A, B...) as SKU's.
    * per pair: 1 driver, 1 navigator
    * For the time being, only two products in stock: A & B
    * Multiple items of the same product can be scanned and they can arrive in any order.
    * Prices

|Item	| Unit  Price	      |    
|-----|---------------------|
|  A  |   50                |
|  B  |   30                | 

1. Code coverage

	* in Visual Studio, go to _Test | Analyse Code Coverage | All Tests_
	* try to obtain 100% code coverage


2. New products

    * switch roles (driver, navigator)
	

|Item	| Unit  Price	      |    
|-----|---------------------|
|  A  |   50                |
|  B  |   30                | 
|  C  |   20                |
|  D  |   15                | 


3. Discounts

	* each navigator goes to the next group and becomes driver there
	* the new navigator wil have to guide the new driver through the code #knowledgesharing
	* introducing discounts


|Item	| Unit  Price | Special price      |    
|-----|---------------|--------------------|
|  A  |   50          |  3 for 130         |
|  B  |   30          |  2 for 45    | 
|  C  |   20          |      |
|  D  |   15          |      | 

4. More changing requirements
    * team members think of interesting changes
	* entire group votes on next change request to implement

5. What's next?
	* democracy!

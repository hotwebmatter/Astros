# Astros

I was unable to add a reference to `System.Windows.Forms` in Visual Studio 2019.

The Reference Manager did not include the "Framework" category.

I attempted to add the reference by browsing the local filesystem and adding a likely-looking DLL, but this approach also failed.

## Example Output
**PROFIT:**
```
**************************************************
        Astros Statement
        Calculate profit or loss
        Matthew Obert
        November 03 2019
**************************************************
This program will calculate profit or loss.

Enter the company's income
When finished with income, enter the company's expenses.

**************************************************

Enter income (enter value or -99 to stop): 700
Enter income (enter value or -99 to stop): xxx
Invalid input.
Enter income (enter value or -99 to stop): 550.50
Enter income (enter value or -99 to stop): 300.25
Enter income (enter value or -99 to stop): -99
Enter expense (enter value or -99 to stop): 400
Enter expense (enter value or -99 to stop): nnnnn
Invalid input.
Enter expense (enter value or -99 to stop): 200.50
Enter expense (enter value or -99 to stop): 100.75
Enter expense (enter value or -99 to stop): -99
**************************************************

Total Income is $1,550.75
Total Expense is $701.25
Total Profit is $849.50

PROFIT

Astros made a profit!
```
**LOSS:**
```
**************************************************
        Astros Statement
        Calculate profit or loss
        Matthew Obert
        November 03 2019
**************************************************
This program will calculate profit or loss.

Enter the company's income
When finished with income, enter the company's expenses.

**************************************************

Enter income (enter value or -99 to stop): 1000.50
Enter income (enter value or -99 to stop): vvv
Invalid input.
Enter income (enter value or -99 to stop): 500.75
Enter income (enter value or -99 to stop): -99
Enter expense (enter value or -99 to stop): 700.25
Enter expense (enter value or -99 to stop): 750.33
Enter expense (enter value or -99 to stop): xxx
Invalid input.
Enter expense (enter value or -99 to stop): 900.25
Enter expense (enter value or -99 to stop): -99
**************************************************

Total Income is $1,501.25
Total Expense is $2,350.83
Total Profit is ($849.58)

LOSS

Astros had a loss.
```

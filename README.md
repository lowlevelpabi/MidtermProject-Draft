# MidtermProject

## Project Description

* Out of your business *

### Changelog

Legend: [ + = added / x - removed / ~ - changed ]

```
 ~   Revamped User Interface in Main Window 
 ```

 * User Interface is changed where the navigation menu from the left side of the window, reposition to the top of the window and removed the text within the button and incorporate icon instead.

 ```
 ~   Login window disappear 
```


* Login window disappear in first run due to incorrect flow of system. The first run now is the main window in order to process first the sign-in if there is no user signed-in


```
 +   Join operation to gather data using this code: Public orderByIdUser As Integer
```

* Variable identifier added to the system to easily retrieve user's purchase history using Join operation


```
 +   Added features in mainForm
```

* mainForm added new tab, 'Purcase History'. 


```
 +   Access checker for null, 'unSession' and 'isLoginSession'
```

* Implement some security wherein, user can't access the 'Purchase History' tab without 'unSession' and 'isLoginSession' values.
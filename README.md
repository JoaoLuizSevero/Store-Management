# Store Management

## About

Store management in **C#** using **SQLite database**.
 
## Main

In main page we can **login** and have access to other areas, but only accordly with **access level** granted to the user that is logged. Login don't allow **spaces** in username or password. The default user credentials is **admin/admin**. (Clicking on the logo you will be **linked** directly to the **Instagram of Visual Cult**, which is actually a **REAL SHOP!!** Feel free to follow us and buy some **products**... :sunglasses:
 
![Main](https://github.com/JoaoLuizSevero/StoreManagement/blob/main/assets/readme/main.PNG)

## Users

In user section we can **delete, create or edit** users, except the **admin**.

![Users](https://github.com/JoaoLuizSevero/StoreManagement/blob/main/assets/readme/user.PNG)

## Items

In item section the operator can **delete, create or edit** items for sale. The **edit** option is the default metod for **stock management** and is directly affected when an item is sold.

![Items](https://github.com/JoaoLuizSevero/StoreManagement/blob/main/assets/readme/item.PNG)

## Operation

The operation section is the **sale management**, where the operator **add or remove** items to the purchase and conclude it. When finished, the user have a option to print the voucher, but if not required this can be done at **sales archive** later. (The operator have to enter the **item ID** manually. Will be implemented a **serial listener** for bar code)

![Operation](https://github.com/JoaoLuizSevero/StoreManagement/blob/main/assets/readme/operation.PNG)

## Archive

In sales archive we can see the **sales** that have been concluded, as well as the **sale ID, date, operator, etc**. In the description column we can see the **sale voucher**, who can be printed.

![Archive](https://github.com/JoaoLuizSevero/StoreManagement/blob/main/assets/readme/sales.PNG)

## Comments

Eventually i will add more features, such as **serial bar code**, item selection in sales operation, etc.

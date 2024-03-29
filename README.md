# SQL Server Index Manager
This application was written due to the fact that I'm needing to be able to manage the databases that the applications I support utilize. In order for the databases to be as efficient as possible they need to utilize indexes. Along with that we need to make sure the indexes are maintained properly. With SQL Server there are two main options and that is to reorganize or reindex. This application allows you to specify the thresholds for when to reorganize and when to reindex and then it can go through each index and take the appropriate measures.


# Forms
## Database Connection Properties
This form is used as a dialog box for users to input the SQL Server connection information. It was modeled after the dialog box that you typically get in SQL Server Management Studio. <br /><br />
<img src="https://user-images.githubusercontent.com/52602914/61195523-39650780-a68e-11e9-8468-1218f1e5a0bf.png" width="350" height="300">


## Fix Indices
<img src="https://user-images.githubusercontent.com/52602914/61195569-75986800-a68e-11e9-9c9f-a9d306f7dfc4.png" width="400" height="300">


## Index Manager
This is the main/initial form.<br /><br />
<img src="https://user-images.githubusercontent.com/52602914/61195601-ac6e7e00-a68e-11e9-9101-4ab8a2edd304.png" width="400" height="300">


## Index Manager Options
This form allows users to change the application settings.<br /><br />
<img src="https://user-images.githubusercontent.com/52602914/61195177-1a657600-a68c-11e9-8396-b61e7df388b0.png" width="350" height="300">

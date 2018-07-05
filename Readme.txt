This is my Test project for stuff that has to do with Xamarin Forms projects.

I will try to keep this updated with the things i Test.

1. Picker binding to Item and User
	Models/User.cs							Add to contain Datastructure for Users
	Models/UserData.cs						Add to contain list of Users, data is initiated in this class
	ViewModels/BaseViewModel.cs				Made a change to OnPropertyChanged, not sure its needed
	ViewModels/ItemDetailViewModel.cs		Add (IList<User> Users), (User SelectedUser), and code for updating Item.User with selected selectedUser.Name
	Views/ItemDetailPage.xaml				Changed Picker Binding (Line 10)
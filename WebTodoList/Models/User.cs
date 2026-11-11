using System.ComponentModel.DataAnnotations;

namespace WebTodoList.Models
{
    public class User
    {
        string userId;
        string userAddress;
        string userFirstName;
        string userLastname;
        string userTelephone;
        int  citeId;
        string userEmail;
        string userNickName;
        string userPassword;
        string userPicture;

        public User(string userId,
                    string userAddress,
                    string userFirstName,
                    string userLastname,
                    string userTelephone,
                    int citeId,
                    string userEmail,
                    string userNickName,
                    string userPassword,
                    string userPicture) 
        
        {
            this.userId = userId;
            this.userAddress = userAddress;
            this.userFirstName = userFirstName;
            this.userLastname = userLastname;
            this.userTelephone = userTelephone;
            this.citeId = citeId;
            this.userEmail = userEmail;
            this.userNickName = userNickName;
            this.userPassword = userPassword;
            this.userPicture = userPicture;
                
        }

        [Required(ErrorMessage = "You must enter an ID number.")]
        [StringLength(9,MinimumLength =9, ErrorMessage = "An ID number consists of 9 digits.")]
        [RegularExpression(@"^\d+$", ErrorMessage = "The field must contain only digits.")]
        public string UserId
        {
            get { return this.userId; }
            set { this.userId = value; }
        }

        [Required(ErrorMessage = "You must enter an user address.")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "An ID number consists of 9 digits.")]
        [RegularExpression(@"^[a-zA-Z0-9\s\.,\-\/]+$", ErrorMessage = "Please use only English letters and numbers.")]
        public string UserAddress
        {
            get { return this.userAddress; }
            set { this.userAddress = value; }
        }

        [Required(ErrorMessage = "You must enter an user first name.")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "A first name contains more letters, or more...")]
        [RegularExpression(@"^[A-Z][a-z]*$", ErrorMessage = "Name must start with a capital letter.")]
        public string UserFirstName
        {
            get { return this.userFirstName; }
            set { this.userFirstName = value; }
        }
        [Required(ErrorMessage = "You must enter an user last name.")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "A last name contains more letters, or more...")]
        [RegularExpression(@"^[A-Z][a-z]*$", ErrorMessage = "Last Name must start with a capital letter.")]
        public string UserLastname
        {
            get { return this.userLastname; }
            set { this.userLastname = value; }
        }


        public string UserTelephone
        {
            get { return this.userTelephone; }
            set { this.userTelephone = value; }
        }

        public int CiteId
        {
            get { return this.citeId; }
            set { this.citeId = value; }
        }

        public string UserEmail
        {
            get { return this.userEmail; }
            set { this.userEmail = value; }
        }

        public string UserNickName
        {
            get { return this.userNickName; }
            set { this.userNickName = value; }
        }

        public string UserPassword
        {
            get { return this.userPassword; }
            set { this.userPassword = value; }
        }

        public string UserPicture
        {
            get { return this.userPicture; }
            set { this.userPicture = value; }
        }

    }
}

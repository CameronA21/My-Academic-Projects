// here i created event listeners so my footer is highlighted when a user hovers. It also turns it back to white when they leave the link.
const highlight = document.getElementById("footerTags");

highlight.addEventListener("mouseover", (event) => {
      event.target.style.color = "red";
    });

highlight.addEventListener("mouseout", (event) => {
    event.target.style.color = "white";
    });

    // this validates the form, not allowing it to be submit until there is text in the textbox. It will alert the user when they have submitted their text.
    function validateForm() {
  
      var formCheck = document.forms.questionsForm.elements;
      var canSubmit = true;
      
      for (var i = 0; i < formCheck.length; i++) {
        if (formCheck[i].value.length == 0) canSubmit = false;
      }
      var submit = document.getElementById("questionsSubmit");
      submit.disabled =!canSubmit;
    }
    
    
    var submit = document.getElementById("questionsSubmit");
    submit.addEventListener("click", function(e) {
      
      e.preventDefault();
      alert("Thank you for your submission");
      questionsForm.reset();
      submit.disabled = true;
    });
    
    // This changes the background color based on what button the user clicks
    var changeColor = document.getElementById("changeColor");
    function changeColor() {   
      document.body.style.backgroundColor = "black";
    }

    var changeColor2 = document.getElementById("changeColor2");
    function changeColor2() {   
      document.body.style.backgroundColor = "white";
    }

    var changeColor3 = document.getElementById("changeColor3");
    function changeColor3() {   
      document.body.style.backgroundColor = "blue";
    }

    var changeColor4 = document.getElementById("changeColor4");
    function changeColor4() {   
      document.body.style.backgroundColor = "green";
    }

    var changeColor5 = document.getElementById("changeColor5");
    function changeColor5() {   
      document.body.style.backgroundColor = "purple";
    }
  
    // document.getElementById("clothingClick") = function () {
  
    //   var msg;
    //   var userInput = document.getElementById("favoriteClothes").value;
      
    //   switch (userInput) {
    //     case "bananas":
    //       msg = "you like bananas";
    //       console.log("you like bananas");
    //       break;
          
    //      case "apples":
    //       msg = "you like apples";
    //       console.log("you like apples");
    //       break;
          
    //      case "avocados":
    //       msg = "you like avocados";
    //       console.log("you like avocados");
    //       break;
          
    //      default:
    //       msg = "We have never heard of " + userInput;
    //       console.log("We have never heard of " + userInput);
    //       break;
          
    //   }
      // var output = document.getElementById("clothingOutput");
      // output.innerHTML = msg;
      
      // }

      // this function takes the users input and gives them a message based on what they wrote
      function clothingButton() {
        clothingClick = document.getElementById("clothingClick");
        var msg = document.getElementById("clothingOutput");
        var userInput = document.getElementById("favoriteClothes").value;
        
        switch (userInput) {
              case "hats":
                msg = "We are selling hats on our products page!";
                console.log("you like hats");
                break;

                case "hat":
                msg = "We are selling hats on our products page!";
                console.log("you like hats");
                break;
                
               case "shirts":
                msg = "Check out our products page for vintage shirts!";
                console.log("you like shirts");
                break;

                case "shirt":
                msg = "Check out our products page for vintage shirts!";
                console.log("you like shirts");
                break;

                case "tshirt":
                msg = "Check out our products page for vintage T-shirts!";
                console.log("you like T-shirts");
                break;

                case "tshirts":
                msg = "Check out our products page for vintage T-shirts!";
                console.log("you like T-shirts");
                break;
                
               case "pants":
                msg = "We sell vintage pants on our products page!";
                console.log("you like pants");
                break;

                case "pant":
                msg = "We sell vintage pants on our products page!";
                console.log("you like pants");
                break;

                case "jeans":
                msg = "We sell vintage jeans on our products page!";
                console.log("you like jeans");
                break;

                case "jean":
                msg = "We sell vintage jeans on our products page!";
                console.log("you like jeans");
                break;

                case "socks":
                msg = "We currently arnt selling socks but that may change in the soon future!";
                console.log("you like socks");
                break;

                case "sock":
                msg = "We currently arnt selling socks but that may change in the soon future!";
                console.log("you like socks");
                break;

                case "gloves":
                msg = "We currently arnt selling gloves but that may change in the soon future!";
                console.log("you like gloves");
                break;

                case "glove":
                msg = "We currently arnt selling gloves but that may change in the soon future!";
                console.log("you like gloves");
                break;

                case "shoes":
                msg = "We sell collectable shoes on our products page!";
                console.log("you like shoes");
                break;

                case "shoe":
                msg = "We sell collectable shoes on our products page!";
                console.log("you like shoes");
                break;

                case "jackets":
                msg = "We sell vintage jackets on our products page!";
                console.log("you like jackets");
                break;

                case "jacket":
                msg = "We sell vintage jackets on our products page!";
                console.log("you like jackets");
                break;

                case "sweatshirts":
                msg = "We sell vintage sweatshirts on our products page!";
                console.log("you like sweatshirts");
                break;

                case "sweatshirt":
                msg = "We sell vintage sweatshirts on our products page!";
                console.log("you like sweatshirts");
                break;
                
               default:
                msg = "We have never heard of " + userInput + ". Tells us more <br> on the about page!";
                console.log("We have never heard of " + userInput + ". Tells us more <br> on the about page!");
                break;
        }
        var output = document.getElementById("clothingOutput");
        output.innerHTML = msg;

        

        
        var notValidMsg = document.getElementById("notValidMsg");

        // this checks the users input and gives them an error message to tell them what they did wrong(if they did something wrong).
        try {

            if(userInput == "") throw "the textbox is empty";
            if(!isNaN(userInput)) throw "you cant enter a number";
            if(userInput == "shirts") throw "";
            if(userInput == "shirt") throw "";
            if(userInput == "hats") throw "";
            if(userInput == "hat") throw "";
            if(userInput == "tshirts") throw "";
            if(userInput == "tshirt") throw "";
            if(userInput == "pants") throw "";
            if(userInput == "pant") throw "";
            if(userInput == "jeans") throw "";
            if(userInput == "jean") throw "";
            if(userInput == "socks") throw "";
            if(userInput == "sock") throw "";
            if(userInput == "gloves") throw "";
            if(userInput == "glove") throw "";
            if(userInput == "shoes") throw "";
            if(userInput == "shoe") throw "";
            if(userInput == "jackets") throw "";
            if(userInput == "jacket") throw "";
            if(userInput == "sweatshirts") throw "";
            if(userInput == "sweatshirt") throw "";

        }
        catch(err) {
            notValidMsg.innerHTML = "Input: " + err;
        }
        finally {
            alert("Thank you for interacting!");
        }

      }
    
var Person = function () {
    this.FirstName = "Elon";
    this.LastName = "Musk";

    this.GetFullName = function () {
        return this.FirstName + " " + this.LastName;
    };
};
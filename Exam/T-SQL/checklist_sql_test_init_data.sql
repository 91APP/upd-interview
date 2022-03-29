CREATE TABLE Member (Member_Id INT IDENTITY (1,1) NOT NULL, Member_Name VARCHAR(20) NOT NULL)
CREATE TABLE Item (Item_Id INT IDENTITY (1,1) NOT NULL, Item_Name VARCHAR(20) NOT NULL)
CREATE TABLE Checked (Checked_Id INT IDENTITY (1,1) NOT NULL, Checked_MemberId INT, Checked_ItemId INT)

INSERT INTO Member (Member_Name) VALUES ('Member A'), ('Member B')
INSERT into Item (Item_Name) VALUES ('Item 1'), ('Item 2'), ('Item 3'), ('Item 4')
INSERT INTO Checked (Checked_MemberId, Checked_ItemId) VALUES (1,1),( 1,3), (1,4) 

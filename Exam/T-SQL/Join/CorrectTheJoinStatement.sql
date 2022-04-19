-- Incorrect SQL statement

SELECT Item_Id, Item_name, Member_Id, Member_Name FROM Item 
LEFT JOIN Checked ON Checked_Itemid = Item_Id
LEFT JOIN Member ON Checked_MemberId = Member_Id AND Member_Name = 'Member A'

-- Expect results

--| Item_Id | Item_Name | Member_Id | Member_Name |
--|---------+-----------+-----------+-------------|
--| 1       | Item 1    | 1         | Member A    |
--| 1       | Item 2    | NULL      | NULL        |
--| 1       | Item 3    | 1         | Member A    |
--| 1       | Item 4    | 1         | Member A    |

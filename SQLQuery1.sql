﻿Select Sum(price) From Books WHERE author = (Select author_id From Authors Where last_name ='Cameron'); 
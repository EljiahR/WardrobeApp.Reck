<h1>Wardrobe Blazor App</h1>
First Blazor application for performing CRUD operations on a wardrobe database.
<h3>Requirements</h3>
  <ul>
     <li>This is an application where you should store and retrieve wardrobe data.</li>
     <li>You should use a Blazor Webassembly project.</li>
     <li>You can choose whatever database solution you want: Sqlite, SQL server or whatever you're comfortable with.</li>
     <li>Since we'll only have basic CRUD operations, you should use Entity Framework.</li>
     <li>Your database should have a single table. The objective is to focus on learning Blazor, so we should avoid the complexities of relational data.</li>
     <li>Users of your app need to be able to upload pictures of wardrobe items.</li>
     <li>You CAN'T USE Javascript interop. The objective is to stay away from JS, even though it's still possible to use it.</li>
  </ul>
<h3>Challenges Faced</h3>
I had a lot of difficulty getting a WASM page to prerender correctly. Originally the prerender took an unreasonable amount of time to load and caused a weird problem where the list of clothing items would be loaded twice. I found that injecting my services into the page was causing both issues, so I opted for injecting an HttpClient instead and hecking for "http" in the url to know when prerendering was done and begin the actual process of getting the items from the database. 

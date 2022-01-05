# API_with_MongoDB

This API is built to interact with a database containing items that might be found in a video game such as swords, potions, armor, etc.

Highlights of API
=================
* Dependency injection into the controller to achieve decoupling.
* Asynchronous programming to increase speed and efficiency.
* Using DTO's to allow for flexible changes as the needs of the API may change over time.
* The use of records to allow otherwise immutable objects to be modified.

Repositories
=================
* A MongoDB database is present through Docker. The MongoDB client is registered as a singleton in order to only have one instance of the repository.
* An in-memory repository was created initially to visualize the items within the repository. It is still present within the API, but is not called upon in Startup.cs.

CRUD Instructions
=================
Examples performed in Postman

* Return all items: GET /items
* Return one item using it's {id}: GET /items/{id}
* Create a new item in the repository: POST /item
* Editing an existing item: PUT /items/{id}  (Body instructions: select 'raw' and set to 'JSON')
* Deleting an existing item: DELET /items/{id}


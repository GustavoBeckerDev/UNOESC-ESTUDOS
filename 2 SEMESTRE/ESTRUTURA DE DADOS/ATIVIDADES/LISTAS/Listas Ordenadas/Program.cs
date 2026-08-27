// AQUI IREMOS ACESSAR APELAS UM ATRIBUTO ESPECÍFICO COM CONDIÇÕES ESPECÍFICAS

// List<string> names = people.Where(p => p.Age <= 30)
//  .OrderBy(p => p.Name)
//  .Select(p => p.Name)
//  .ToList();

// AQUI TAMBEM ACESSAMOS NAMES E ORDENAMOS COM AS FUNÇÕES LINQ

// List<string> names = (from p in people
//  where p.Age <= 30
//  orderby p.Name
//  select p.Name).ToList();

List<Cars> car = new List<Cars>();

car.Add(
    new Cars()
    {
        Model = "CELTA",
        Year = 2008,
        CarColor = ColorsEnum.BLACK
    }
);

car.Add(
    new Cars()
    {
        Model = "CORSA",
        Year = 2011,
        CarColor = ColorsEnum.BLUE
    }
);

car.Add(
    new Cars()
    {
        Model = "ONIX",
        Year = 2025,
        CarColor = ColorsEnum.WHITE
    }
);

car.Add(
    new Cars()
    {
        Model = "GOL",
        Year = 2018,
        CarColor = ColorsEnum.RED
    }
);


// List<Cars> CasrsNames = (from p in people
//  where p.Age <= 30
//  orderby p.Name
//  select p.Name).ToList();

 // TAREFA PRA CASA TOPICO LISTAS LINKADAS


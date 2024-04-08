use test
DELETE [AbilityBonuses];
DROP  TABLE [AbilityBonuses];
CREATE TABLE [dbo].[Ability] (
    [ability_id]     INT  NOT NULL,   
    [ability_name] TEXT NOT NULL,
    PRIMARY KEY CLUSTERED ([ability_id] ASC)
);

CREATE TABLE [dbo].[AbilityBonuses] (
    [bonus_id]     INT  NOT NULL,
    [race_id]      INT  NOT NULL,
    [bonus_value]  INT  NOT NULL,
    PRIMARY KEY CLUSTERED ([bonus_id] ASC),
    FOREIGN KEY ([race_id]) REFERENCES [dbo].[Race] ([Id_Race]),
    FOREIGN KEY ([bonus_id]) REFERENCES [dbo].[Ability] ([ability_id])
);

Insert Ability values(1,'ловкость')
Insert Ability values(2,'сила')
Insert Ability values(3,'телосложение')
Insert Ability values(4,'интелект')
Insert Ability values(5,'мудрость')
Insert AbilityBonuses values(6,'харизма')

Insert AbilityBonuses values(1,1,2)

Insert AbilityBonuses values(1,2,1)
Insert AbilityBonuses values(2,2,1)
Insert AbilityBonuses values(3,2,1)
Insert AbilityBonuses values(4,2,1)
Insert AbilityBonuses values(5,2,1)
Insert AbilityBonuses values(6,2,1)

Insert AbilityBonuses values(4,3,2)

Insert AbilityBonuses values(1,4,2)

Insert AbilityBonuses values(3,5,2)

Insert AbilityBonuses values(4,6,2)

Insert AbilityBonuses values(6,7,2)
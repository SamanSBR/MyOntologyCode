class Relation:
    """
    A connection between entities.
    Meaning begins here.
    """

    def __init__(self, source, target, label="relates-to"):
        self.source = source
        self.target = target
        self.label = label

    def __repr__(self):
        return f"{self.source} -[{self.label}]-> {self.target}"

class TimeOrder:
    """
    Not clock-time.
    Just ordering.
    """

    def __init__(self):
        self.sequence = []

    def mark(self, event):
        self.sequence.append(event)

    def before(self, a, b) -> bool:
        return self.sequence.index(a) < self.sequence.index(b)
